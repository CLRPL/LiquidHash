using System;

namespace LiquidHash.UX.Data
{
    public class CredentialsEventArgs : EventArgs
    {
        public string ProtectedResource;
        public string Username;
        public string Password;
        public bool CredentialsProvided;
    }
}
