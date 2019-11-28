 static readonly string _paymentDetailsCategoryIdWithCustomerInfo = "0A1D3DDC-0778-4D0E-93CA-5F241B0E7242";
        static readonly string _paymentDetailsCategoryIdWithoutCustomerInfo = "0A1D3DDC-0778-4D0E-93CA-5F241B0E7242";

private static async Task<HttpResponseMessage> AddPaymentInfoCategory(HttpRequestMessage req, InputParameters inputParameters)
{
    var request = new HttpRequestMessage(new HttpMethod("PATCH"),
        $"{inputParameters.HostUrl}/v1/inspections/{inputParameters.CurrentInspectionId}/categories/addcategorytype?categoryTypeId={_paymentDetailsCategoryIdWithoutCustomerInfo}");

    if (true) // in offsite, there are customerInfo (customerName, customerId)
    {
        request = new HttpRequestMessage(new HttpMethod("PATCH"),
            $"{inputParameters.HostUrl}/v1/inspections/{inputParameters.CurrentInspectionId}/categories/addcategorytype?categoryTypeId={_paymentDetailsCategoryIdWithCustomerInfo}");
    }

    var categoryResponse = await _httpClient.SendAsync(request);
    if (!categoryResponse.IsSuccessStatusCode)
    {
        return req.CreateResponse(HttpStatusCode.BadRequest);
    }

    return req.CreateResponse(HttpStatusCode.OK);
}


////////////////////////////////////////////////////////////////////////////////////////////////////////////////


if (responseObj.extendedInformation.InspektInspectionAutoPaid != "true") {
    return req.CreateResponse(HttpStatusCode.OK); // i.e. Not an offsite so exit
}


/////////////////////////////////////////////////////////////////////////////////////////
body('Parse_JSON_-_Previous_Inspection')?['previousInspection']?['inspectionId']
body('DetermineIfInspectionRecheck')?['previousInspection']?['inspectionId']


concat(parameters('fieldPineRaiseSaleInpektApi'),'/v1/inspections/',triggerBody()?['externalId'],'/categories/',body('Parse_Customer_Infor_Category')?['categoryId'])

outputs('Compose_-_Customer_Information')?['categoryId']

setProperty(outputs('Compose_-_Customer_Information')?['schemaData']?['customerInformation'],'receiptNo',string(body('DevFieldPinePosRaiseSale')?['data']?['Sid']))



//////////ODATA///////////////////////////

http://localhost:55386/v1/oData/search?$filter=Subtitle eq 'aar113' and Status eq 'PreReadyToStart'


https://devinspekt.search.windows.net/indexes/uat-azuresql-index-inspekt-inspection/docs?api-version=2017-11-11&searchFields=BaseInformation,ExternalInspectionId&searchMode=all&queryType=full&search=Subtitle eq 'CKQ429' and TenantId eq 'ef7a6aab-e8aa-4bd5-b9eb-f92a433e194b'



///////////////////////////////////////////////////////////////////////////////////////////
https://devinspekt.search.windows.net/indexes/uat-azuresql-index-inspekt-inspection/docs?api-version=2017-11-11&searchFields=BaseInformation,Subtitle&searchMode=all&queryType=full&search=
(BaseInformation:("\"rego\":\"UO4962\""  AND  "\"vin\":\"JHDFD3HLKXXX10200\""))  AND  (Subtitle eq 'UO4962') &$filter= TenantId eq 'ef7a6aab-e8aa-4bd5-b9eb-f92a433e194b'

searchFields=BaseInformation&searchMode=all&queryType=full&search=(BaseInformation:("\"rego\":\"UO4962\""  AND  "\"vin\":\"JHDFD3HLKXXX10200\""))  &$filter= TenantId eq 'ef7a6aab-e8aa-4bd5-b9eb-f92a433e194b'



https://devinspekt.search.windows.net/indexes/uat-azuresql-index-inspekt-inspection/docs?api-version=2017-11-11&searchFields=BaseInformation&searchMode=all&queryType=full&search=(BaseInformation%3A(%22%5C%22rego%5C%22%3A%5C%22UO4962%5C%22%22%20%20AND%20%20%22%5C%22vin%5C%22%3A%5C%22JHDFD3HLKXXX10200%5C%22%22))%20%20&%24filter=%20TenantId%20eq%20'ef7a6aab-e8aa-4bd5-b9eb-f92a433e194b'
https://devinspekt.search.windows.net/indexes/uat-azuresql-index-inspekt-inspection/docs?api-version=2017-11-11&searchFields=BaseInformation&searchMode=all&queryType=full&search=(BaseInformation:("\"rego\":\"UO4962\""  AND  "\"vin\":\"JHDFD3HLKXXX10200\""))  &$filter= TenantId eq 'ef7a6aab-e8aa-4bd5-b9eb-f92a433e194b'






//backup -working version
setProperty(outputs('Compose_-_Customer_Information')?['schemaData']?['customerInformation'],'receiptNo',string(body('FieldPinePosRaiseSale')?['data']?['Sid']))

// backup - working verion 2
if(
    equals(outputs('Compose_-_Customer_Information')?['schemaData']?['customerInformation'],null),
    addProperty(outputs('Compose_-_Customer_Information')?['schemaData'],'receiptNo',string(body('FieldPinePosRaiseSale')?['data']?['Sid'])),
    setProperty(outputs('Compose_-_Customer_Information')?['schemaData']?['customerInformation'],'receiptNo',string(body('FieldPinePosRaiseSale')?['data']?['Sid']))
    )

// backup - working version 3
if(equals(outputs('Compose_-_Customer_Information')?['schemaData']?['customerInformation'],null),addProperty(outputs('Compose_-_Customer_Information')?['schemaData'],'receiptNo',string(body('FieldPinePosRaiseSale')?['data']?['Sid'])),setProperty(outputs('Compose_-_Customer_Information')?['schemaData']?['customerInformation'],'receiptNo',string(body('FieldPinePosRaiseSale')?['data']?['Sid'])))

/////////////////////////////////////////////////
if( equals(outputs('Compose_-_Customer_Information')?['schemaData']?['customerInformation'], null),
    addProperty(outputs('Compose_-_Customer_Information')?['schemaData'],'customerInformation', '{"receiptNo": "daniel"}'),    
    setProperty(
    outputs('Compose_-_Customer_Information')?['schemaData']?['customerInformation'],
    'receiptNo',
    string(body('FieldPinePosRaiseSale')?['data']?['Sid'])
    )
   )


body('Get_Location_By_ExternalId')?['extendedInformation']?['FieldPinePosCustomerId']


https://devinspekt.search.windows.net/indexes/uat-azuresql-index-inspekt-inspection/docs?api-version=2017-11-11&searchFields=BaseInformation&searchMode=all&queryType=full&search=(BaseInformation:("\"rego\":\"UO4962\""  AND  "\"vin\":\"JHDFD3HLKXXX10200\""))  &$filter= TenantId eq 'ef7a6aab-e8aa-4bd5-b9eb-f92a433e194b'Deleted eq false and 