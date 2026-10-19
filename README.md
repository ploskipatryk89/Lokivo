Lokivo
Lokivo is a long-term rental management platform being developed as an engineering degree project. It is designed for private landlords and companies managing their own properties or properties on behalf of other owners.
The platform will combine a web application for rental management with a mobile application for tenants, maintenance staff, and property owners.
Supported Business Models
- Private landlords — individuals managing their own rental properties.
- Companies renting out their own properties — businesses managing a portfolio they own.
- Property management companies — businesses managing rental properties on behalf of external owners.
Each individual or company will operate within an organization, with access controlled through organization memberships and assigned permissions.
Planned Features
- User registration, authentication, and organization management.
- Role-based access for administrators, tenants, maintenance staff, and property owners.
- Property and rental unit management.
- Tenant and lease management.
- Rent, payment, and expense tracking.
- Maintenance requests and task assignment.
- Property owner access to relevant property information.
- Business reports and data exports.
- Document generation using customizable templates.
Technology Stack
- Backend: C#, ASP.NET Core Web API
- Authentication: ASP.NET Core Identity
- Data access: Entity Framework Core
- Web application: React
- Mobile application: React Native
Architecture
The backend is organized into four layers:
- Domain — business entities, value objects, and business rules.
- Application — use cases, application workflows, and interfaces.
- Infrastructure — persistence, Identity integration, and implementations of external services.
- API — HTTP endpoints and the entry point for web and mobile clients.
Both client applications will use a shared backend API.
Project Status
The project is in its initial development stage. Current work focuses on the backend structure, identity model, and registration flow for users and organizations.
The features described above represent the planned scope and will be implemented incrementally.
