using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace RemoteObj
{
    class Remoted : MarshalByRefObject
    {
        Hashtable ChatLg = new Hashtable();
        ArrayList OnlineUser = new ArrayList();
        private int key = 0;

       public bool JoinToChatRoom(string Name)
        {
            if (OnlineUser.IndexOf(Name) > -1)
            {
                return false;
            }
            else
            {
                OnlineUser.Add(Name);
                SendMessage(Name + "님이 방에 입장하셨습니다.");
                return true;
            }
        }
        
        public void LeaveChatRoom(string Name)
        {
            OnlineUser.Remove(Name);
            SendMessage(Name + "님이 퇴장하셨습니다.");
        }

        public ArrayList GetOnlineList()
        {
            return OnlineUser;
        }

        public int CurrentKey()
        {
            return key;
        }

        public void SendMessage(string ChatMage)
        {
            ChatLg.Add(++key, ChatMage);
        }

        public string GetMsg(int lastKey)
        {
            if (key > lastKey)
            {
                return ChatLg[lastKey + 1].ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
