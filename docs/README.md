


#  Payment Rails C# SDK

## Index

### Packages

* [Exceptions](packages/exceptions.md)


### Classes

* [BalancesGateway](classes/balancesgateway.md)
* [BatchGateway](classes/batchgateway.md)
* [Configuration](classes/configuration.md)
* [Gateway](classes/gateway.md)
* [PaymentGateway](classes/paymentgateway.md)
* [RecipientAccount](classes/recipientaccount.md)
* [RecipientAccountGateway](classes/recipientaccountgateway.md)
* [RecipientGateway](classes/recipientgateway.md)


### Types

* [Batch](types/batch.md)
* [ConfigurationParams](types/configurationparams.md)
* [Payment](types/payment.md)
* [Recipient](types/recipient.md)


---


Create a client for the Payment Rails C# API


	var client = new PaymentRails_Gateway("MY_PUBLIC_KEY", "MY_PRIVATE_KEY", "production");

**Parameters:**

| Param | Type | Description |
| ------ | ------ | ------ |
| publicKey | [String]   |  The public key |
| secretKey | [String]   |  The secret key |
| enviroment | [String]   |  The enviroment which should be used |





**Returns:** [Gateway](classes/gateway.md)





___


