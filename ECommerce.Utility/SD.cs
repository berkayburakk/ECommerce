using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Utility
{
    public static class SD
    {

        // bu classa static değişmeyen tanımlamalar yapılır. örneğin adminin rolü gibi
        public const string Proc_CoverType_Create = "usp_CreateCoverType";
        public const string Proc_CoverType_Get = "usp_GetCoverType";
        public const string Proc_CoverType_GetAll = "usp_GetCoverTypes";
        public const string Proc_CoverType_Update = "usp_UpdateCoverType";
        public const string Proc_CoverType_Delete = "usp_DeleteCoverType";

        public const string Role_User_Indi = "Individual Customer";
        public const string Role_User_Comp = "Company Customer";
        public const string Role_Admin = "Admin";
        public const string Role_Employee = "Employee";

        public const string ssShoppingCart = "Shoping Cart Session";

        public const string StatusPending = "Bekleniyor";
        public const string StatusApproved = "Onaylandi";
        public const string StatusInProcess = "İşleme geçildi";
        public const string StatusShipped = "Kargolandi";
        public const string StatusCancelled = "İptal Edildi";
        public const string StatusRefunded = "İade edildi";

        public const string PaymentStatusPending = "Bekleniyor";
        public const string PaymentStatusApproved = "Onaylandı";
        public const string PaymentStatusDelayedPayment = "Geciken Odeme onaylandi";
        public const string PaymentStatusRejected = "Reddedildi";

        public static string ConvertToRawHtml(string source)
        {
            char[] array = new char[source.Length];
            int arrayIndex = 0;
            bool inside = false;

            for (int i = 0; i < source.Length; i++)
            {
                char let = source[i];
                if (let == '<')
                {
                    inside = true;
                    continue;
                }
                if (let == '>')
                {
                    inside = false;
                    continue;
                }
                if (!inside)
                {
                    array[arrayIndex] = let;
                    arrayIndex++;
                }
            }
            return new string(array, 0, arrayIndex);
        }

    }
}
