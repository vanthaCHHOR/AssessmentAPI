# AssessmentAPI


+ Article API Call by Postman

	- Create Article 
		+ API : http://localhost:64366/api/Articles/
		+ Method : POST
		+ request JSON : 
			{
			  "ID": "sample string 1",
			  "ARTICLE_TITLE": "sample string 2",
			  "DESCRIPTION": "sample string 3",
			  "CREATED_AT": "2018-12-02T18:48:17.348058+07:00"
			}
		+ response JSON :
			{
				"ID": "sample string 1",
				"ARTICLE_TITLE": "sample string 2",
				"DESCRIPTION": "sample string 3",
				"CREATED_AT": "2018-12-02T18:48:17.348058+07:00"
			}
	
	- Delete Article by Id
		+ API : http://localhost:64366/api/Articles/8bd6144c-97a0-4328-8be4-39f1d1550240
		+ Method : DELETE
		
	- Get All Article
		+ API : http://localhost:64366/api/Articles/
		+ Method : GET
		+ Response JSON :
			[
				{
					"ID": "7d207f44-54d0-4021-8071-da331e5892c9",
					"ARTICLE_TITLE": "IT News",
					"DESCRIPTION": "IT News",
					"CREATED_AT": "2018-12-03T00:00:00"
				},
				{
					"ID": "da3e5acd-10f0-44d0-a0a7-2a05c6faab43",
					"ARTICLE_TITLE": "Math",
					"DESCRIPTION": "Math",
					"CREATED_AT": "2018-12-02T00:00:00"
				},
				{
					"ID": "e519298e-6cc7-4c8b-81ba-94af4546cb64",
					"ARTICLE_TITLE": "ABC",
					"DESCRIPTION": "ABC",
					"CREATED_AT": "2018-12-01T00:00:00"
				}
			]
	- Search Article by CREATE DATE
		+ http://localhost:64366/api/Articles/2018-12-02
		+ Method : GET
		+ Response JSON :
			[
				{
					"id": "da3e5acd-10f0-44d0-a0a7-2a05c6faab43",
					"ArticleName": "Math",
					"Description": "Math",
					"Create_at": "2018-12-02T00:00:00"
				},
				{
					"id": "e519298e-6cc7-4c8b-81ba-94af4546cb64",
					"ArticleName": "ABC",
					"Description": "ABC",
					"Create_at": "2018-12-01T00:00:00"
				}
			]
			
			
	
		
		
