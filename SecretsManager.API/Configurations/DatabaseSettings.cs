using System;

namespace SecretsManager.API.Configurations;

public class DatabaseSettings
{
    public const string SectionName = "Database";
    public string ConnectionString { get; set; } = default!;
}
