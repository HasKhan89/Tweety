using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tweety
{
    public class MyTwitterDB : DbContext
    {
        public DbSet<CekirdekTweet> Tweetler { get; set; }
    }

    [Table("Tweets")]
    public class CekirdekTweet
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string IdStr { get; set; }           // Tweet Id

        [Required, StringLength(30)]
        public string ScreenName { get; set; }      // Tweet User ScreenName

        public long UserId { get; set; }            // Tweet User Id

        public DateTime CreatedDate { get; set; }   // Tweet Created Date

        [StringLength(150)]
        public string Text { get; set; }            // Tweet Text
    }
}
