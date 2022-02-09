Product 1.0
-Name: string
-Preco: double
-Quantity: int
-----------------------------
+ TotalValueInStok(): double
+ AddProducts(quantity: int):void
+ RemoveProducts(quantity: int):void
------------------------------------
Product 2.0

Improvement proposal
• Let's create an optional constructor, which receives only name and
price of the product. The quantity in stock of this new product, for
default, it should then start with a value of zero.
• Note: you can also include a default builder (without
parameters)