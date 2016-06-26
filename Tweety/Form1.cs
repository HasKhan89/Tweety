using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweetSharp;

namespace Tweety
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TwitterService _Service = null;
        private List<TwitterStatus> _Tweets = null;
        private MyTwitterDB _DB = new MyTwitterDB();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Twitter app oluşturma..(bu yapılmalı)
            // http://www.mintik.com/2014/02/12/twitter-uygulama-olusturma.html

            string consumerKey = ConfigurationManager.AppSettings["ConsumerKey"];
            string consumerSecret = ConfigurationManager.AppSettings["ConsumerSecret"];
            string accessTokenKey = ConfigurationManager.AppSettings["AccessTokenKey"];
            string accessTokenSecret = ConfigurationManager.AppSettings["AccessTokenSecret"];

            // Twitter için yetkilendirme ayarlarım yapıldı.
            _Service = new TwitterService(consumerKey, consumerSecret);
            _Service.AuthenticateWith(accessTokenKey, accessTokenSecret);

            // Database yoksa oluştur. (1. Yöntem)
            //if(_DB.Database.Exists() == false)
            //{
            //    _DB.Database.Create();
            //}

            // Database yoksa oluştur. (2. Yöntem)
            _DB.Database.CreateIfNotExists();
        }

        private void btnListHomelineTweets_Click(object sender, EventArgs e)
        {
            // Ana sayfa tweetlerim.
            _Tweets = _Service.ListTweetsOnHomeTimeline(
                new ListTweetsOnHomeTimelineOptions()).ToList();

            // Veritabanındaki tweetler..
            List<CekirdekTweet> vt_tweets = _DB.Tweetler.ToList();

            // İnterntten çektiğimiz tweetlerde dönülür.
            foreach (TwitterStatus t in _Tweets)
            {
                // Veritabanında o tweet varmı kontrol edilir.
                CekirdekTweet ct = vt_tweets.Where(x => x.IdStr == t.IdStr).FirstOrDefault();

                // Yoksa veritabanında insert yapılır.
                if (ct == null)
                {
                    // Yeni cekirdekTweet oluştur..
                    ct = new CekirdekTweet()
                    {
                        IdStr = t.IdStr,
                        CreatedDate = t.CreatedDate,
                        ScreenName = t.User.ScreenName,
                        UserId = t.User.Id,
                        Text = t.Text
                    };

                    // insert...
                    _DB.Tweetler.Add(ct);
                }   
            }   // Foreach

            _DB.SaveChanges();

            List<string> screenNames = (from t in _Tweets
                                        orderby t.User.ScreenName
                                        select t.User.ScreenName).Distinct().ToList();

            cmbScreenNames.DataSource = screenNames;
        }

        private void cmbScreenNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbScreenNames.SelectedIndex > -1)
            {
                string secliScreenName = cmbScreenNames.SelectedItem.ToString();

                List<string> tweetTexts = (from t in _Tweets
                                           where t.User.ScreenName == secliScreenName
                                           orderby t.CreatedDate descending
                                           select t.Text).ToList();

                // DataSource özelliğini kullandığımız için;
                // lstTweets.Items.Clear() yapmaya gerek yoktur. 
                // lstTweets.Items.Add() metodu ile item ekleyemem.
                lstTweets.DataSource = tweetTexts;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var listSubscriptions = _Service.ListSubscriptions(new ListSubscriptionsOptions());
            //var listFollowers = _Service.ListFollowers(new ListFollowersOptions());
            
        }

        private void btnListMyTweets_Click(object sender, EventArgs e)
        {
            // Kendi tweetlerim.
            _Tweets = _Service.ListTweetsOnUserTimeline(new ListTweetsOnUserTimelineOptions()).ToList();

            // Veritabanındaki tweetler..
            List<CekirdekTweet> vt_tweets = _DB.Tweetler.ToList();

            // İnterntten çektiğimiz tweetlerde dönülür.
            foreach (TwitterStatus t in _Tweets)
            {
                // Veritabanında o tweet varmı kontrol edilir.
                CekirdekTweet ct = vt_tweets.Where(x => x.IdStr == t.IdStr).FirstOrDefault();

                // Yoksa veritabanında insert yapılır.
                if (ct == null)
                {
                    // Yeni cekirdekTweet oluştur..
                    ct = new CekirdekTweet()
                    {
                        IdStr = t.IdStr,
                        CreatedDate = t.CreatedDate,
                        ScreenName = t.User.ScreenName,
                        UserId = t.User.Id,
                        Text = t.Text
                    };

                    // insert...
                    _DB.Tweetler.Add(ct);
                }
            }   // Foreach

            _DB.SaveChanges();

            lstTweets.DataSource = (from t in _Tweets
                                    select t.Text).ToList();

        }

        private void btnYeniTweetGonder_Click(object sender, EventArgs e)
        {
            string text = txtYeniTweet.Text;

            SendTweetOptions opt = new SendTweetOptions();
            opt.Status = text;

            _Service.SendTweet(opt);
        }
    }
}
