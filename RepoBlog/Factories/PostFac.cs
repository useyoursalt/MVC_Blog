using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepoBlog.Models.ViewModels;
using RepoBlog.Models.BaseModels;

namespace RepoBlog.Factories
{
    public class PostFac:AutoFac<Post>
    {
        BilledeFac bf = new BilledeFac();

        public List<BlogIndex> GetIndexData()
        {
            List<BlogIndex> list = new List<BlogIndex>();

            foreach(var post in GetAll())
            {
                BlogIndex bi = new BlogIndex();
                bi.Post = post;
                bi.Billeder = bf.GetBy("PostID", post.ID);
                list.Add(bi);
            }

            return list;
        }
    }
}
