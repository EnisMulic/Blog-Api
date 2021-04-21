# Blog Api

If the application doesn't work locally, try starting up docker and running:

```
docker-compose up --build
```

## Testing

You can navigate to `https://localhost:44396/swagger` and test the API with the Swagger client or using Postman.  
Import `Blog.API.postman_collection.json` into Postman as a quickstart.

-   Note: The seeding data is generated with [Bogus](https://github.com/bchavez/Bogus) so it will not be complient with the slug/title rule.
