using Microsoft.PowerBI.Api.Extensions;
using Microsoft.PowerBI.Api.Models;
using Microsoft.PowerBI.Api.Models.Credentials;
using System;
using System.Collections.Generic;
using System.Fabric;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMOProject
{
   
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            var credentials = new BasicCredentials(username: "arpitmasih", password: "Techment@123");

            var publicKey = new GatewayPublicKey("<exponent>", "<modulus>");

            var credentialsEncryptor = new AsymmetricKeyEncryptor(publicKey);
            var credentialDetails = new CredentialDetails(credentials, PrivacyLevel.Organizational, EncryptedConnection.Encrypted, credentialsEncryptor);
            Console.WriteLine(credentialDetails);
        }

       
    }


}
