using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Morpions.BDD_MorpionsTableAdapters;

namespace Morpions
{
    public class User
    {
        int _USER_ID;
        string  _USER_LOGIN;
        string _USER_PASSWORD;
        string _USER_EMAIL;
        string _USER_NAME;
        string _USER_SURNAME;
        string _USER_IP;
        int _USER_WIN_PLAYER;
        int _USER_WIN_COMPUTER;
        int _USER_DRAW_PLAYER;
        int _USER_DRAW_COMPUTER;
        int _USER_LOSE_PLAYER;
        int _USER_LOSE_COMPUTER;
        int _USER_XP;



        public int USER_ID
        {
            get { return _USER_ID; }
            set { _USER_ID = value; }
        }

        public string USER_LOGIN
        {
            get { return _USER_LOGIN; }
            set { _USER_LOGIN = value; }
        }

        public string USER_PASSWORD
        {
            get { return _USER_PASSWORD; }
            set { _USER_PASSWORD = value; }
        }

        public string USER_EMAIL
        {
            get { return _USER_EMAIL; }
            set { _USER_EMAIL = value; }
        }

        public string USER_NAME
        {
            get { return _USER_NAME; }
            set { _USER_NAME = value; }
        }

        public string USER_SURNAME
        {
            get { return _USER_SURNAME; }
            set { _USER_SURNAME = value; }
        }

        public string USER_IP
        {
            get { return _USER_IP; }
            set { _USER_IP = value; }
        }

        public int USER_WIN_PLAYER
        {
            get { return _USER_WIN_PLAYER; }
            set { _USER_WIN_PLAYER = value; }
        }

        public int USER_WIN_COMPUTER
        {
            get { return _USER_WIN_COMPUTER; }
            set { _USER_WIN_COMPUTER = value; }
        }

        public int USER_DRAW_PLAYER
        {
            get { return _USER_DRAW_PLAYER; }
            set { _USER_DRAW_PLAYER = value; }
        }

        public int USER_DRAW_COMPUTER
        {
            get { return _USER_DRAW_COMPUTER; }
            set { _USER_DRAW_COMPUTER = value; }
        }
 
        public int USER_LOSE_PLAYER
        {
            get { return _USER_LOSE_PLAYER; }
            set { _USER_LOSE_PLAYER = value; }
        }

        public int USER_LOSE_COMPUTER
        {
            get { return _USER_LOSE_COMPUTER; }
            set { _USER_LOSE_COMPUTER = value; }
        }
      
        public int USER_XP
        {
            get { return _USER_XP; }
            set { _USER_XP = value; }
        }

        //constructeur
        public User()
        { 
        }

        //constructeur
        public User(string VUSER_LOGIN, string VUSER_PASSWORD, string VUSER_EMAIL, string VUSER_NAME,
                    string VUSER_SURNAME, string VUSER_IP, int VUSER_WIN_PLAYER, int VUSER_WIN_COMPUTER,
                    int VUSER_DRAW_PLAYER, int VUSER_DRAW_COMPUTER, int VUSER_LOSE_PLAYER, int VUSER_LOSE_COMPUTER,
                    int VUSER_XP)
        {
            USER_LOGIN = VUSER_LOGIN;
            USER_PASSWORD = VUSER_PASSWORD;
            USER_EMAIL = VUSER_EMAIL;
            USER_NAME = VUSER_NAME;
            USER_SURNAME = VUSER_SURNAME;
            USER_IP = VUSER_IP;
            USER_WIN_PLAYER = VUSER_WIN_PLAYER;
            USER_WIN_COMPUTER = VUSER_WIN_COMPUTER;
            USER_DRAW_PLAYER = VUSER_DRAW_PLAYER;
            USER_DRAW_COMPUTER = VUSER_DRAW_COMPUTER;
            USER_LOSE_PLAYER = VUSER_LOSE_PLAYER;
            USER_LOSE_COMPUTER = VUSER_LOSE_COMPUTER;
            USER_XP = VUSER_XP;

        }


        //constructeur
        public User(int VUSER_ID)
        {
            using (USERTableAdapter adapter = new USERTableAdapter())
             {
                BDD_Morpions.USERDataTable table = adapter.GetDataByID(VUSER_ID);
                if (!table.Rows.Count.Equals(0))
                {
                    BDD_Morpions.USERRow LigneData = (BDD_Morpions.USERRow)table.Rows[0];
                    USER_ID = LigneData.USER_ID;
                    USER_LOGIN = LigneData.USER_LOGIN;
                    USER_PASSWORD = LigneData.USER_PASSWORD;
                    USER_EMAIL = LigneData.USER_EMAIL;
                    USER_NAME = LigneData.USER_NAME;
                    USER_SURNAME = LigneData.USER_SURNAME;
                    USER_IP = LigneData.USER_IP;
                    USER_WIN_PLAYER = LigneData.USER_WIN_PLAYER;
                    USER_WIN_COMPUTER = LigneData.USER_WIN_COMPUTER;
                    USER_DRAW_PLAYER = LigneData.USER_DRAW_PLAYER;
                    USER_DRAW_COMPUTER = LigneData.USER_DRAW_COMPUTER;
                    USER_LOSE_PLAYER = LigneData.USER_LOSE_PLAYER;
                    USER_LOSE_COMPUTER = LigneData.USER_LOSE_COMPUTER;
                    USER_XP = LigneData.USER_XP;
                }
            }
        }

        public DataTable GetTableUser()
        {
            using (USERTableAdapter adapter = new USERTableAdapter())
            {
                return adapter.GetData();
            }
        }

        public DataTable GetTableUserbyID(int VID_USER)
        {
            using (USERTableAdapter adapter = new USERTableAdapter())
            {
                return adapter.GetDataByID(VID_USER);
            }
        }

        public void DeleteUser(int VUSER_ID)
        {
            using (USERTableAdapter adapter = new USERTableAdapter())
            {
                adapter.DeleteQuery(VUSER_ID);
            }
        }

        public void UpdateUser(int VUSER_ID)
        {
            using (USERTableAdapter adapter = new USERTableAdapter())
            {
                adapter.UpdateQuery(_USER_LOGIN, _USER_PASSWORD, _USER_EMAIL, _USER_NAME, _USER_SURNAME,
                                    _USER_IP, _USER_WIN_PLAYER, _USER_WIN_COMPUTER, _USER_DRAW_PLAYER,
                                    _USER_DRAW_COMPUTER, _USER_LOSE_PLAYER, _USER_LOSE_COMPUTER, _USER_XP, VUSER_ID);
            }
        }

        public void AddUser()
        {
            using (USERTableAdapter adapter = new USERTableAdapter())
            {
                adapter.InsertQuery(_USER_LOGIN, _USER_PASSWORD, _USER_EMAIL, _USER_NAME, _USER_SURNAME,
                                    _USER_IP, _USER_WIN_PLAYER, _USER_WIN_COMPUTER, _USER_DRAW_PLAYER,
                                    _USER_DRAW_COMPUTER, _USER_LOSE_PLAYER, _USER_LOSE_COMPUTER, _USER_XP);
            }
        }
    }
}
