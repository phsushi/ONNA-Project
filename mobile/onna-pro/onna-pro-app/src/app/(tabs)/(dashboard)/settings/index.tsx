import React, { useEffect } from "react"
import { SafeAreaView, View, StatusBar, Text } from "react-native"

import { colors } from "@/styles/colors"

import { MaterialIcons } from "@expo/vector-icons"

import Toast from "react-native-toast-message"
import { showToast } from "@/components/toast"

import { Link } from "expo-router"

export default function Settings() {
    // hooks
    useEffect(() => {
        const Load = async () => {
        }
        
        Load()
    }, [])
    
    return (
        <SafeAreaView className="flex-1 bg-gray" >   
            <View className="w-full h-full justify-center items-center gap-[50px]" >
                <StatusBar barStyle={"dark-content"} />

                <View className="w-[75%] h-[75px] bg-white flex-row justify-center items-center rounded-full shadow-black shadow-xl gap-[82.5px]" >
                    <MaterialIcons name="account-circle" color={colors.davys} size={25} />
                    <Link href={"/settings/profile"} >
                        <Text className="text-[18.75px] color-black font-Imedium" >Perfil</Text>
                    </Link>
                    <MaterialIcons name="chevron-right" color={colors.davys} size={25} />
                </View>

                <View className="w-[75%] h-[75px] bg-white flex-row justify-center items-center rounded-full shadow-black shadow-xl gap-[48px]" >
                    <MaterialIcons name="notifications" color={colors.davys} size={25} />
                    <Link href={"/settings/notifications"} >
                        <Text className="text-[18.75px] color-black font-Imedium" >Notificações</Text>
                    </Link>
                    <MaterialIcons name="chevron-right" color={colors.davys} size={25} />
                </View>

                <View className="w-[75%] h-[75px] bg-white flex-row justify-center items-center rounded-full shadow-black shadow-xl gap-[20px]" >
                    <MaterialIcons name="description" color={colors.davys} size={25} />
                    <Text className="text-[18.75px] color-black font-Imedium" >Termos de serviço</Text>
                    <MaterialIcons name="chevron-right" color={colors.davys} size={25} />
                </View>

                <View className="w-[75%] h-[75px] bg-white flex-row justify-around items-center rounded-full shadow-black shadow-xl gap-[40px]" >
                    <MaterialIcons name="help" color={colors.davys} size={25} />
                    <Text className="text-[18.75px] color-black font-Imedium" >Ajuda</Text>
                    <MaterialIcons name="chevron-right" color={colors.davys} size={25} />
                </View>
            </View>
            <Toast />
        </SafeAreaView>
    )
}