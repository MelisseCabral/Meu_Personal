﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_Gym_JM_final.UserServices;

namespace App_Gym_JM_final.Communication
{
    class Chat_Personal : Chat
    {
        public Chat_Personal(User userOwner, User userFriend) : base(userOwner, userFriend)
        {
        }
    }
}