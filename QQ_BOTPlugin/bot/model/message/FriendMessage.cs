﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQ_BOTPlugin.bot.model.message
{

    public class FriendMessageSender
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string nickname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string remark { get; set; }

    }



    public class FriendMessage
    {
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public FriendMessageSender sender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<object> messageChain { get; set; }


        public FriendMessage(string param)
        {
            FriendMessage resp = SimpleJson2.SimpleJson2.DeserializeObject<FriendMessage>(param);
            this.type = resp.type;
            this.sender = resp.sender;
            this.messageChain = MessageParser.ParseMessage(resp.messageChain); ;
        }
        public FriendMessage()
        {
        }
    }
}
