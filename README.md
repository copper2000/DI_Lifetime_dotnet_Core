## Dependency Injection Life Cycle: Transient, Singleton, and Scoped ##

- **Transient**: An instance will be created each time it is requested
- **Scoped**: Create an instance for every scope(each request is a scope). In each scope, the service is reused
- **Singleton**: The service will be created only once
