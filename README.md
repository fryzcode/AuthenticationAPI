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
  "password": "password123",
  "roles": ["user"]
}

```

### 2. Login

Authenticate the user with their credentials.

**Endpoint:** `POST /api/auth/login`

**Request Parameters:**
```json
{
  "username": "exampleUser",
  "password": "password123"
}
```

### 3. ConfirmEmail

Confirm the user's email address after registration.

**Endpoint:** `POST /api/auth/confirm-email`

**Request Parameters:**
```json
{
  "userId": "user123",
  "token": "confirmationToken123"
}
```

### 4. LoginWithOTP

Authenticate the user using a one-time password (OTP).

**Endpoint:** `POST /api/auth/login-with-otp`

**Request Parameters:**
```json
{
  "username": "exampleUser",
  "otp": "123456"
}
```

### 5. RefreshToken

Refresh the access token using a refresh token.

**Endpoint:** `POST /api/auth/refresh-token`

**Request Parameters:**
```json
{
  "refreshToken": "refreshToken123"
}
```

### 6. ForgotPassword

Initiate the user password recovery process.

**Endpoint:** `POST /api/auth/forgot-password`

**Request Parameters:**
```json
{
  "email": "user@example.com"
}
```

### 7. ResetPassword

Reset the user's password after a password reset request.

**Endpoint:** `POST /api/auth/reset-password`

**Request Parameters:**
```json
{
  "userId": "user123",
  "token": "resetToken123",
  "newPassword": "newPassword123"
}
```

## Notes

- All requests must include the header `Content-Type: application/json`.
- Check response status codes and error handling in API responses.
- Documentation may be updated to reflect changes in the API. Stay updated with the latest version of the documentation.
```

Feel free to use this single file for your README documentation.

