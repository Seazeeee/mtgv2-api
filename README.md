# MTGv2 API

A RESTful OData API for Magic: The Gathering card data, built with ASP.NET Core and PostgreSQL. This API serves as the frontend interface for the [MTGv2 data pipeline](https://github.com/Seazeeee/mtgv2).

## Overview

This API provides programmatic access to comprehensive MTG card data including:

- Card information (name, type, mana cost, power/toughness)
- Pricing data from multiple sources (TCGPlayer, CardKingdom, CardMarket)
- Format legality across various formats (Standard, Modern, Legacy, Commander, etc.)
- Set information and release dates
- Image URLs for card artwork

## Architecture

This API is part of the larger MTGv2 ecosystem:

```
Raw Data → Staging → Intermediate → Marts → **API** (this project)
```

The API consumes data from the `mart_card_catalog` view, which is populated by the [MTGv2 data pipeline](https://github.com/Seazeeee/mtgv2) that processes data from:

- Scryfall API
- Commander Spellbook API

## Technology Stack

- **Framework**: ASP.NET Core 9.0
- **Database**: PostgreSQL with Entity Framework Core
- **API Protocol**: OData v4
- **Authentication**: JWT (planned)
- **ORM**: Entity Framework Core with Npgsql

## Features

### OData Query Support

- **Filtering**: `$filter=cmc eq 3 and colors eq 'Blue'`
- **Ordering**: `$orderby=price_usd desc`
- **Pagination**: `$top=10&$skip=20`
- **Selection**: `$select=card_name,cmc,price_usd`
- **Expansion**: `$expand=related_entities`

## Getting Started

### Prerequisites

- .NET 9.0 SDK
- PostgreSQL database with `mart_card_catalog` view
- Connection string configured in User Secrets

### Installation

```bash
# Clone the repository
git clone <repository-url>
cd mtgv2-api

# Restore dependencies
dotnet restore

# Configure connection string
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "your-connection-string"

# Run the application
dotnet run
```

The API will be available at `http://localhost:5043`

### Example Queries

```bash
# Get all cards
curl "http://localhost:5043/odata/Cards"

# Get first 10 cards
curl "http://localhost:5043/odata/Cards?\$top=10"

# Filter by converted mana cost
curl "http://localhost:5043/odata/Cards?\$filter=cmc eq 3"

# Order by price descending
curl "http://localhost:5043/odata/Cards?\$orderby=price_usd desc&\$top=5"

# Select specific fields
curl "http://localhost:5043/odata/Cards?\$select=card_name,cmc,price_usd&\$top=10"
```

## Related Projects

- **[MTGv2 Data Pipeline](https://github.com/Seazeeee/mtgv2)** - The main data pipeline that processes raw MTG data and populates the database tables consumed by this API
- **MTGv2 Discord Bot** - Planned Discord bot that will consume this API for card lookups and combo analysis

## Development

### Project Structure

```
mtgv2-api/
├── Controllers/          # OData controllers
├── Models/              # Entity models
├── data/                # DbContext and database configuration
├── Properties/          # Launch settings
└── Program.cs           # Application configuration
```

### Adding New Endpoints

1. Create new controller inheriting from `ODataController`
2. Add entity to `MtgContext`
3. Configure in `Program.cs` EDM model
4. Update routing as needed

## Future Enhancements

- [ ] JWT Authentication with Keycloak
- [ ] Rate limiting and API key management
- [ ] Caching layer for improved performance

## License

MIT License - see [LICENSE](LICENSE) file for details.

## Acknowledgments

- [Scryfall](https://scryfall.com/) for comprehensive MTG card data
- [Commander Spellbook](https://commanderspellbook.com/) for combo data
- The MTG community for data validation and feedback
