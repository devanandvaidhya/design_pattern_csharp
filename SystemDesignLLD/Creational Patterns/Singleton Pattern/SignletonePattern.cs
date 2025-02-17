using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesignLLD.Creational_Patterns.Singleton_Pattern
{

    public class AppSetting
    {
    // step 1: private static instace of the class

        private static AppSetting instance;

        private string databaseUrl;
        private string apiKey;

        // step 2 : private constructor to prevent direct object creation.

        private AppSetting() 
        {
            databaseUrl = "sql://localhost:3306/mydatabase-ecom";
            apiKey = "AcVgLh-25Gv";
        }

        // step 3 : public static method to get the single instance.

        public static AppSetting getInstance()
        {
            if (instance == null)
            {
                instance = new AppSetting();
            }
            return instance;
        }

        public string DatabaseUrl()
        {
            return databaseUrl;
        }

        public string  ApiKey()
        {
            return apiKey;
        }
    }

    public class SignletonePattern
    {


        public void MainMethod()
        {
            AppSetting appSetting1 = AppSetting.getInstance();
            AppSetting appSetting2 = AppSetting.getInstance();

            Console.WriteLine(appSetting1.ApiKey());
            Console.WriteLine(appSetting2.ApiKey());

            Console.WriteLine(appSetting1==appSetting2);

        }
        
    }
}
