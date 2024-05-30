using System.Security.Cryptography.X509Certificates;

namespace Week_4_Challenge_Labs_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "()[]{}";

            Console.WriteLine(IsValidInput(s));

            bool IsValidInput(string userString)
            
           {
                
                
                Dictionary <string, string>characterDict = new Dictionary<string, string>();
                characterDict["["] = "]";
                characterDict["{"] = "}";
                characterDict["("] = ")";
                
                int leftPointer = 0;
                int rightPointer = 1;

                if (userString ==null) 
                { 
                    return false;
                }
                
                while (rightPointer < userString.Length) 
                {
                    if (!characterDict.ContainsKey(Convert.ToString(userString[leftPointer]))) 
                    {
                        return false;
                    }

                    else if (characterDict[Convert.ToString(userString[leftPointer])] == Convert.ToString(userString[rightPointer]))
                    {
                        leftPointer += 2;
                        rightPointer += 2;

                       
                    }
                } 
                return true;
            }  

           

            

            

            
            
        }
    }
}
