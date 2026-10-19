using System.ComponentModel.Design;

namespace advanced1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1 
            //generic class can work with different data types using a type parameter 

            //we use it to reuse code avoid dupication improve type safety

            #endregion


            #region question3
            //A generic class can have more than one type parameter 

            #endregion

            #region question4 
            // is a method that uses a type parameter to work with diffrent data types 

            #endregion

            #region question5
            //method that  uses a type parameter to find maximum value between two cmparable value 

            #endregion

            #region question6
            // cant answer
            #endregion


            #region qusetion8 
            //the class constraints alows only refrence type , values types are not allowed
            //classconstraints<string> obj = new classconstraints <string>();

            //obj.Value = "omar";

            //Console.WriteLine(obj.Value);
            #endregion

            #region question9
            //the new constraint requires that the type has a parameterless constructour it allows to create new instance of T  using new T()

            //الexample معرفتش اعمله صح
            #endregion

            #region question10
            //cant answer
            #endregion
            #region question11
            //cant answer
            #endregion

            #region 12
            // cant answer
            #endregion

            #region 13
            //returns the default value of a type 
            #endregion
            #region 14
            //safelist<int> list = new safelist<int>();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);

            //Console.WriteLine(list.Get(0));
            //Console.WriteLine(list.Get(2));
            //Console.WriteLine(list.Get(5));

            #endregion

            #region 15
            //covariance allows using a more derived type instead of base type using out keyword
            #endregion
            #region 16
            //allows using a base type where a derived type is expected ituses the in keyword
            #endregion

            #region 17
            //Covariance:  Allow using a derived type instead of  base type
            //Contravariance:  Allow using a base type instead of  derived type
            #endregion

            #region 18
            //cannot answer
            #endregion

            #region 19
            // by passing the type parameter to the base class
            #endregion
            #region 20
            //cannot answer 
            #endregion
        }
    }
}
