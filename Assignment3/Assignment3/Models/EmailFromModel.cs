using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Assignment3.Models
{
    public class EmailFromModel
    {

        public string To { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public HttpPostedFileBase uploadFile { get; set; }


    }
}
