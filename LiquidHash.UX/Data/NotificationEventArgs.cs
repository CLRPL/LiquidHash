using LiquidHash.MobileMiner.Data;
using System;

namespace LiquidHash.UX.Data
{
    public class NotificationEventArgs : EventArgs
    {
        public string Id;
        public string Text;
        public Action ClickHandler;
        public NotificationKind Kind;
        public string InformationUrl;
    }
}
