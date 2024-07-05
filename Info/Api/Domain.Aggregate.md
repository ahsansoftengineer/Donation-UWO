# Domain Aggregates

### User
```csharp
class User
{
    // TODO: Add methods
}
```
```json
{
  "id": { "value": "00000000-0000-0000-0000-000000000000" },
  "firstName": "Tiffany",
  "lastName": "Doe",
  "email": "user@gmail.com",
  "password": "Amiko1232!", // TODO: Hash this
  "createdDateTime": "2020-01-01T00:00:00.0000000Z",
  "updatedDateTime": "2020-01-01T00:00:00.0000000Z"
}
### Menu Review
```csharp
class MenuReview
{
    // TODO: Add methods
}
```
```json
{
  "id": { "value": "00000000-0000-0000-0000-000000000000" },
  "rating": 4,
  "comment": "A menu with yummy food",
  "hostId": { "value": "00000000-0000-0000-0000-000000000000" },
  "menuId": { "value": "00000000-0000-0000-0000-000000000000" },
  "guestId": { "value": "00000000-0000-0000-0000-000000000000" },
  "dinnerId": { "value": "00000000-0000-0000-0000-000000000000" },
  "createdDateTime": "2020-01-01T00:00:00.0000000Z",
  "updatedDateTime": "2020-01-01T00:00:00.0000000Z"
}
```
### Dinner
```csharp
class Dinner
{
    // TODO: Add methods
}
```
```json
{
  "id": { "value": "00000000-0000-0000-0000-000000000000" },
  "name": "Yummy Dinner",
  "description": "A dinner with yummy food",
  "startDateTime": "2020-01-01T00:00:00.0000000Z",
  "endDateTime": "2020-01-01T00:00:00.0000000Z",
  "startedDateTime": null,
  "endedDateTime": null,
  "status": "Upcoming", // Upcoming, InProgress, Ended, Cancelled
  "isPublic": true,
  "maxGuests": 10,
  "price": {
    "amount": 10.99,
    "currency": "USD"
  },
  "hostId": { "value": "00000000-0000-0000-0000-000000000000" },
  "menuId": { "value": "00000000-0000-0000-0000-000000000000" },
  "imageUrl": "https://image.com",
  "location": {
    "name": "Dan's Pizza Place",
    "address": "Berlin, Germany",
    "latitude": 52.520008,
    "longitude": 13.404954
  },
  "reservations": [
    {
      "id": { "value": "00000000-0000-0000-0000-000000000000" },
      "guestCount": 2,
      "reservationStatus": "Reserved", // PendingGuestConfirmation, Reserved, Canceled
      "guestId": { "value": "00000000-0000-0000-0000-000000000000" },
      "billId": { "value": "00000000-0000-0000-0000-000000000000 }",
      "arrivalDateTime": null,
      "createdDateTime": "2020-01-01T00:00:00.0000000Z",
      "updatedDateTime": "2020-01-01T00:00:00.0000000Z"
    }
  ],
  "createdDateTime": "2020-01-01T00:00:00.0000000Z",
  "updatedDateTime": "2020-01-01T00:00:00.0000000Z"
}
```
### Guest
```csharp
class Guest
{
    // TODO: Add methods
}
```
```json
{
  "id": { "value": "00000000-0000-0000-0000-000000000000" },
  "firstName": "John",
  "lastName": "Doe",
  "profileImage": "https://www.gravatar.com/avatar/00000000000000000000000000000000?d=mp",
  "averageRating": 4.5,
  "userId": { "value": "00000000-0000-0000-0000-000000000000" },
  "upcomingDinnerIds": [
    { "value": "00000000-0000-0000-0000-000000000000" }
  ],
  "pastDinnerIds": [
    { "value": "00000000-0000-0000-0000-000000000000" }
  ],
  "pendingDinnerIds": [
    { "value": "00000000-0000-0000-0000-000000000000" }
  ],
  "billIds": [
    { "value": "00000000-0000-0000-0000-000000000000" }
  ],
  "menuReviewIds": [
    { "value": "00000000-0000-0000-0000-000000000000" }
  ],
  "ratings": [
    {
      "id": { "value": "00000000-0000-0000-0000-000000000000" },
      "hostId": { "value": "00000000-0000-0000-0000-000000000000" },
      "dinnerId": { "value": "00000000-0000-0000-0000-000000000000" },
      "rating": 4,
      "createdDateTime": "2020-01-01T00:00:00.0000000Z",
      "updatedDateTime": "2020-01-01T00:00:00.0000000Z"
    }
  ],
  "createdDateTime": "2020-01-01T00:00:00.0000000Z",
  "updatedDateTime": "2020-01-01T00:00:00.0000000Z"
}
```
### Host
```csharp
class Host
{
    // TODO: Add methods
}
```
```json
{
  "id": { "value": "00000000-0000-0000-0000-000000000000" },
  "firstName": "Tiffany",
  "lastName": "Doe",
  "profileImage": "https://www.gravatar.com/avatar/00000000000000000000000000000000?d=mp",
  "averageRating": 4.5,
  "userId": { "value": "00000000-0000-0000-0000-000000000000" },
  "menuIds": [
      { "value": "00000000-0000-0000-0000-000000000000" }
  ],
  "dinnerIds": [
      { "value": "00000000-0000-0000-0000-000000000000" }
  ],
  "createdDateTime": "2020-01-01T00:00:00.0000000Z",
  "updatedDateTime": "2020-01-01T00:00:00.0000000Z"
}
```
### Menu
```csharp
class Menu
{
    Menu Create();
    void AddDinner(Dinner dinner);
    void RemoveDinner(Dinner dinner);
    void UpdateSection(MenuSection section);
    // TODO: Add remaining methods
}
```
```json
{
  "id": { "value": "00000000-0000-0000-0000-000000000000" },
  "name": "Yummy Menu",
  "description": "A menu with yummy food",
  "averageRating": 4.5,
  "sections": [
      {
          "id": { "value": "00000000-0000-0000-0000-000000000000" },
          "name": "Appetizers",
          "description": "Starters",
          "items": [
              {
                  "id": { "value": "00000000-0000-0000-0000-000000000000" },
                  "name": "Fried Pickles",
                  "description": "Deep fried pickles"
              }
          ]
      }
  ],
  "hostId": { "value": "00000000-0000-0000-0000-000000000000" },
  "dinnerIds": [
      { "value": "00000000-0000-0000-0000-000000000000" }
  ],
  "menuReviewIds": [
      { "value": "00000000-0000-0000-0000-000000000000" }
  ],
  "createdDateTime": "2020-01-01T00:00:00.0000000Z",
  "updatedDateTime": "2020-01-01T00:00:00.0000000Z"
}
```

