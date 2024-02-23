using Assets.Scripts.Classes;
using Assets.Scripts.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Managers
{
    internal class SessionManager
    {
        static public List<Session> GetSessions()
        {
            return new List<Session>();
        }

        static public Session GetSession(int id)
        {
            return new Session();
        }
    }
}
