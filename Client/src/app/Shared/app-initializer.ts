import { AuthService } from "./Services/auth.service";
import { SettingService } from "./Services/setting.service";

export function appInitializer(authService: AuthService): () => Promise<void> {
    return async () => authService.loadCurrentUser();
}


export function appSettingsInitializer(settingService: SettingService): () => Promise<void> {
    return async () => settingService.loadappSettings();
}
