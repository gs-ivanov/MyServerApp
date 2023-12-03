namespace MyServer.Common
{
    using System;

    public class Guard
    {
        public static void AgainstNull(object value, string name = null)
        {
            if (value == null)
            {
                name ??= "Value";  //?? - ako name niyama stoinost to name="Value"

                throw new ArgumentException($"{name} cannot be null.");
            }


            // Git check

        }
    }
}
