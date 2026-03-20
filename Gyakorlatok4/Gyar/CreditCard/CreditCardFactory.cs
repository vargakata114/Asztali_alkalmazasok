using Factory.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.CreditCard
{
    internal class CreditCardFactory : Factory.Framework.Factory
    {
        public CreditCardFactory()
        // ˅

        // ˄
        {
            // ˅

            // ˄
        }

        public override IProduct CreateProduct(string owner)
        {
            // ˅
            return new CreditCard(owner);
            // ˄
        }

        // ˅

        // ˄
    }
}