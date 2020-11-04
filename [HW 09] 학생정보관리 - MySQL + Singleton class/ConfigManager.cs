using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _HW_09__학생정보관리___MySQL___Singleton_class
{
    public class ConfigManager
    {
        private static ConfigManager instance = new ConfigManager();

        public static ConfigManager getInstance()
        {
            return instance;
        }

        private ConfigManager()
        {
            
        }

        // DB에 저장된 recent_first 값(최근 사용 전공 부터 로드할지 여부)을 확인하여 반환
        public int getRecentFrist()
        {
            string selectQuery = "SELECT recent_first FROM config WHERE id=1;";
            MySqlDataReader rdr = DBManager.getInstance().select(selectQuery);
            rdr.Read();
            int recentFirst = Convert.ToInt32(rdr["recent_first"]);
            rdr.Close();

            return recentFirst;
        }

        // DB에 저장된 recent_major 값(최근에 사용한 전공의 id값)을 반환
        public int getRecentMajor()
        {
            string selectQuery = "SELECT recent_major FROM config WHERE id=1;";
            MySqlDataReader rdr = DBManager.getInstance().select(selectQuery);
            rdr.Read();
            int majorId = Convert.ToInt32(rdr["recent_major"]);
            rdr.Close();

            return majorId;
        }

        // DB에 저장된 auto_load 값을 확인하고 반환
        public int getAutoLoad()
        {
            string selectQuery = "SELECT auto_load FROM config WHERE id=1;";
            MySqlDataReader rdr = DBManager.getInstance().select(selectQuery);
            rdr.Read();
            int autoLoad = Convert.ToInt32(rdr["auto_load"]);
            rdr.Close();

            return autoLoad;
        }
    }
}
