# Authentication API

The Authentication API provides methods for managing users and authentication processes.

## Methods

### 1. Register

Registers a new user in the system.

**Endpoint:** `POST /api/auth/register`

**Request Parameters:**
```json
{
  "username": "exampleUser",
  "email": "user@example.com",
  "password": "password123"
  "roles": [user]
}

### 2. Login

Authenticate the user with their credentials.

**Endpoint:** `POST /api/auth/login`

**Request Parameters:**
```json
{
  "username": "exampleUser",
  "password": "password123"
}

