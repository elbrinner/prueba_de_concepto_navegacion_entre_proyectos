using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepto.BaseCore.Helpers
{
    public class RegisterScreen
    {
        public static Dictionary<string, System.Type> registerModuleScreen = new Dictionary<string, System.Type>();

        public RegisterScreen()
        {
            RegisterScreen.registerModuleScreen = new Dictionary<string, System.Type>();
        }

        public bool Register(string interfaceType, Type concreteType)
        {
            if (registerModuleScreen.FirstOrDefault(x => x.Key == interfaceType).Value == null)
            {
                registerModuleScreen.Add(interfaceType, concreteType);
                return true;
            }
            return false;

        }

        public static void AddViewModel(string nameKey,System.Type arquitectureKey)
        {
           if(registerModuleScreen == null)
            {
                RegisterScreen.registerModuleScreen = new Dictionary<string, System.Type>();
            }
             if (!string.IsNullOrEmpty(nameKey))
            {
                if (RegisterScreen.registerModuleScreen.FirstOrDefault(x => x.Key == nameKey).Value == null)
                {
                     RegisterScreen.registerModuleScreen.Add(nameKey, arquitectureKey);  
                }
                            
            }
        }

        public static System.Type GetArquitectureKey(string ViewModeKey)
        {
            try
            {
                if (registerModuleScreen.FirstOrDefault(x => x.Key == ViewModeKey).Value == null)
                {


                }else
                {
                    return registerModuleScreen.FirstOrDefault(x => x.Key == ViewModeKey).Value;
                }
            }
            catch (Exception ex)
            {
              
            }

            return null;
        }
    }
}
