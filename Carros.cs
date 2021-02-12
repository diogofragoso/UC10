using System;
using System.Globalization;
using System.Collections.Generic;


namespace Switch_Case
{

    class Carros{

        string _nome = "";
        public string Nome { 
            
            
            get{ return _nome;}     
        
        
         set{
                if(value != null){

                    _nome =  value;
                }
             
         }
         
          }

    }

}