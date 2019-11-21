SELECT CategoryId, CategoryInformation FROM [dbo].[Categories] where InspectionId = '2058e2d9-fc64-47dd-9362-f9ad939ab85b' and Name = 'Payment Information'

DELETE FROM [dbo].[Categories] WHERE Name = 'Payment Information' and InspectionId = '2058e2d9-fc64-47dd-9362-f9ad939ab85b'



UPDATE [dbo].[Categories]
SET CategoryInformation = '{
  "payment": {
    "recheckFee": "RC 1 - $16.00",
    "orderNumber": "dsada",
    "notes": "dsadad",
	"paymentType": "account",
	"account": "daniel"
  }
}'
WHERE CategoryId = 'CEED3FCD-3CA5-49B0-93C7-9D092E1320AC'



UPDATE [dbo].[Categories]
SET CategoryInformation = null
WHERE CategoryId = '7BDED260-A6FB-4A5F-9EA0-A09A4E9AA184'


SELECT CategoryId, CategoryInformation FROM [dbo].[Categories] where InspectionId = '228a99ef-14b0-4afa-8e95-d685187e1c40' and Name = 'Fees'



