﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebChat.Models
{
    public class MessageFormViewModel
    {
        private MessageRepository messageRep;
        private ChannelRepository channelRep;
        private UserRepository userRep;

        public Chatroom chat { get; set; }
        public Message mess { get; set; }
        public List<Message> messes { get; private set; }
        public aspnet_User user { get; set; }

        public MessageFormViewModel(int id) 
        {
            userRep = new UserRepository();
            messageRep = new MessageRepository();
            channelRep = new ChannelRepository();
            chat = channelRep.showChatroom(id);
            user = userRep.getOwner(channelRep.showChatroom(id));
            mess = new Message();
            messes = messageRep.showChatroomMessages(id).ToList();
            
        }
        public MessageFormViewModel(int id, Message mess)
        {
            userRep = new UserRepository();
            messageRep = new MessageRepository();
            channelRep = new ChannelRepository();
            chat = channelRep.showChatroom(id);
            user = userRep.getOwner(channelRep.showChatroom(id));
            messes = messageRep.showChatroomMessages(id).ToList();
        }

    }
}