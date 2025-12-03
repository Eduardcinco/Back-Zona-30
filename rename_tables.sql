-- Renombrar tablas de PascalCase a snake_case para que coincidan con el código
RENAME TABLE RefreshTokens TO refresh_tokens;

-- Verificar que se renombró
SHOW TABLES LIKE '%refresh%';
