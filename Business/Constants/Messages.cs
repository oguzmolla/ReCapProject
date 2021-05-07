using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        #region Car Messages
        public static string CarAdded = "Araba eklendi.";
        public static string CarDeleted = "Araba silindi.";
        public static string CarUpdated = "Araba Güncellendi.";
        #endregion

        #region Customer Messages
        public static string CustomerAdded = "Customer eklendi.";
        public static string CustomerDeleted = "Customer silindi.";
        public static string CustomerUpdated = "Customer Güncellendi.";

        public static string CarAlreadyRented = "Bu araba başkasına kiralanmıştır";
        #endregion
    }
}
