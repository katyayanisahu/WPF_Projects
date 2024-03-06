using System.Collections.Generic;

namespace ValidatePostTransaction
{
    public class NamesCollection
    {
        string[] names = new string[] { "REID", "PIN" };
       
    }
    public class ValidatePostModel
    {

        int[] Oid = new int[] { 216189, 216190 , 216191, 216192}; 
        int[] Feature_key = new int[] { 206678, 206679, 206680, 206681 };
        string[] Update_insert = new string[] { "INSERT", "INSERT", "INSERT", "INSERT" };
        string[] Update_delete = new string[] { "DELETE", "DELETE", "DELETE", "DELETE" };
        string[] Error_message = new string[] { " ", " ", " ", " " };

        public List<InsertUpdate> GetPeople(int total = 4)
        {
            List<InsertUpdate> output = new List<InsertUpdate>();

            for (int i = 0; i < total; i++)
            {

                output.Add(GetData(i));
            }

            return output;
        }
        
      private InsertUpdate GetData(int i)
        {
            InsertUpdate output = new InsertUpdate();

            //output.OID = Oid;
            output.OID = Oid[i];
            output.FEATURE_KEY = Feature_key[i];
            output.UPDATE_INSERT = Update_insert[i];
            output.ERROR_MESSAGE = Error_message[i];

            return output;
        }

        public List<DeleteUpdate> GetPeople1(int total = 4)
        {
            List<DeleteUpdate> output = new List<DeleteUpdate>();

            for (int i = 0; i < total; i++)
            {

                output.Add(GetData1(i));
            }

            return output;
        }
        private DeleteUpdate GetData1(int i)
        {
            DeleteUpdate output = new DeleteUpdate();

            //output.OID = Oid;
            output.OID = Oid[i];
            output.FEATURE_KEY = Feature_key[i];
            output.UPDATE_DELETE = Update_delete[i];
            output.ERROR_MESSAGE = Error_message[i];

            return output;
        }

    }
}
