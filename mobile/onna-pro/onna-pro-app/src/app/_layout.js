import { Stack } from 'expo-router';

export default function Layout(){
    return(
        <Stack
            screenOptions={{
                headerTintColor: "#000000",
                headerShadowVisible: false,
            }}
        >
            <Stack.Screen name="index" options={{ headerShown: false }} />
            <Stack.Screen name="login" options={{ title: "", headerStyle: { backgroundColor: "#E8FCCF" } }} />
            <Stack.Screen name="signUp" options={{ title: "", headerStyle: { backgroundColor: "#E8FCCF" }  }} />
        </Stack>
    )
}