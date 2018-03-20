using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RedisDome
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            string UserName;
            //读取数据，如果缓存存在直接从缓存中读取，否则从数据库读取然后写入redis
            using (var redisClient = RedisManager.GetClient())
            {
                UserName = redisClient.Get<string>("UserInfo_123");
                if (string.IsNullOrEmpty(UserName)) //初始化缓存
                {
                    //TODO 从数据库中获取数据，并写入缓存
                    UserName = "张三";
                    redisClient.Set<string>("UserInfo_123", UserName, DateTime.Now.AddSeconds(10));
                    lbtest.Text = "数据库数据：" + "张三";
                    return;
                }
                lbtest.Text = "Redis缓存数据：" + UserName;
            }
        }
    }
}