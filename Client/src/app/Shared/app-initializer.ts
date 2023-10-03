import { AuthService } from "./Services/auth.service";
import { SettingService } from "./Services/setting.service";

// App initializer function for loading the current user's data
export function appInitializer(authService: AuthService): () => Promise<void> {
    return async () => {
        // Call the authService to load the current user's data
        await authService.loadCurrentUser();
    };
}

// App initializer function for loading application settings
export function appSettingsInitializer(settingService: SettingService): () => Promise<void> {
    return async () => {
        // Call the settingService to load application settings
        await settingService.loadappSettings();
    };
}
