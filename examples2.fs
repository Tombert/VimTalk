


                (@"merchantname", x.MerchantName);
                (@"manufacturer", x.Manufacturer); 
                (@"title", x.Title); 
                (@"quantity", string x.Quantity); 
                (@"minordescription", defaultArg x.MinorDescription "") 
                (@"referenceprice", toCurrency x.ReferencePrice); 
                (@"effectiveprice", toCurrency x.EffectivePrice) ; 
                (@"imgurl", x.Imgurl); 
                (@"retail_skuid", defaultArg x.RetailSkuid ""); 
                (@"categorypath", x.CategoryPath); 
                (@"categoryid", string x.CategoryId); 
                (@"isfresh", if x.IsFresh then "true" else null) ; 
                (@"itemsavings", string (toCurrencyOption x.ItemSavings)); 
                (@"itemdiscounts", string (toCurrencyOption x.ItemDiscounts)); 
                (@"itemtax", string (toCurrencyOption x.ItemTax)); 
                (@"nonreturnable", string x.Nonreturnable); 
                (@"estimateddeliverydate", x.EstimatedDeliveryDate); 
                (@"reason",  defaultArg x.ReturnReason ""); 
                (@"returnfee", string (toCurrencyOption x.ReturnFee)); 

