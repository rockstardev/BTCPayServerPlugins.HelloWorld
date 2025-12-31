# Hello World Plugin for BTCPay Server

A simple demonstration plugin showing the basic structure and conventions for developing BTCPay Server plugins.

## Features

- Adds a "Hello World" navigation item to the header menu
- Displays a simple welcome page
- Demonstrates the basic plugin architecture

## Plugin Structure

```
BTCPayServer.RockstarDev.Plugins.HelloWorld/
├── Controllers/
│   └── HelloWorldController.cs       # Handles HTTP requests
├── Views/
│   ├── HelloWorld/
│   │   └── Index.cshtml              # Main Hello World page
│   ├── Shared/
│   │   └── HelloWorld/
│   │       └── NavExtension.cshtml   # Navigation menu item
│   └── _ViewImports.cshtml           # View imports and tag helpers
├── HelloWorldPlugin.cs               # Main plugin class
├── BTCPayServer.RockstarDev.Plugins.HelloWorld.csproj  # Project file
└── README.md                         # This file
```

## Key Components

### 1. Plugin Class (`HelloWorldPlugin.cs`)
The main plugin class that inherits from `BaseBTCPayServerPlugin`:
- Defines plugin dependencies (requires BTCPay Server >= 2.1.0)
- Registers UI extensions via `AddUIExtension`
- Configures services in the `Execute` method

### 2. Controller (`HelloWorldController.cs`)
A simple MVC controller that:
- Routes requests to `/plugins/hello-world`
- Allows anonymous access
- Returns the Index view

### 3. Views
- **Index.cshtml**: The main Hello World page with Bootstrap styling
- **NavExtension.cshtml**: Adds a navigation link to the header menu

## How It Works

1. The plugin is loaded by BTCPay Server at startup
2. The `Execute` method registers a UI extension for the header navigation
3. The navigation item appears in the header menu
4. Clicking the link navigates to `/plugins/hello-world`
5. The controller renders the Index view with a welcome message

## Building and Testing

To build the plugin:
```bash
dotnet build
```

To test the plugin locally, you'll need to:
1. Build BTCPay Server with plugin support
2. Copy the plugin DLL to the BTCPay Server plugins directory
3. Restart BTCPay Server

## Extending This Plugin

You can extend this plugin by:
- Adding more controllers and views
- Registering services in the DI container
- Adding database models and migrations
- Implementing background services
- Adding API endpoints
- Creating custom payment methods
- And much more!

## Resources

- [BTCPay Server Plugin Documentation](https://docs.btcpayserver.org/Development/Plugins/)
- [BTCPay Server GitHub](https://github.com/btcpayserver/btcpayserver)

## License

This plugin follows the same license as the repository it's contained in.
