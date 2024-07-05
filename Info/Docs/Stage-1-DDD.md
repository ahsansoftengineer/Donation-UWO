## Stage 1 
1. Impl Auth 
2. Service Added into Api 

####  Donation.Application
- AuthenticationService, IAuthenticationService, AuthenticationResult has (Register and Login Defined)
- Utilized by API

#### Donation.Contracts
- AuthenticationResponse
- LoginResponse
- RegisterRequest
- Utilized by API

#### Donation.Api 
- Controller with Action (Register, Login)
- Register and Login Type Defined  Separately

## Stage 2
- Impl JWT
- Service Added into Api

#### Donation.Application
- Common > 
- - Interfaces > Authentication > IJwtTokenGenerator
- - Services > IDateTimeProvider
- - Persistence > IUserRepository
- Utilized by Infrastructure

#### Donation.Infrastructure
- Authentication > JwtSettings, JwtTokenGenerator
- Services > DateTimeProvider
- Persistence > UserRepository

#### Donation.Api
- Utilized in Donation.Api Layer as per old implementation

### Images
![Design 1](https://github.com/ahsansoftengineer/donation-DDD/blob/5-Mapster-ObjectMapping/Info/Images/Domain%20Driven%20Design.png)
![Design 2](https://github.com/ahsansoftengineer/donation-DDD/blob/5-Mapster-ObjectMapping/Info/Images/Domain%20Driven%20Design%202.png)
![Design 3](https://github.com/ahsansoftengineer/donation-DDD/blob/5-Mapster-ObjectMapping/Info/Images/Domain%20Driven%20Design%203.png)




