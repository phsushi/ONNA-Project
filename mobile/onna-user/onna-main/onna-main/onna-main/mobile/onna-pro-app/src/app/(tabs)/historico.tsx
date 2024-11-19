import React, { useState } from "react"
import { SafeAreaView, View, StatusBar, StyleSheet, Text, Image, Pressable } from "react-native"

import { colors } from "@/styles/colors"
import { fontFamily } from "@/styles/fontFamily"

import { MaterialIcons } from "@expo/vector-icons"

import { Link } from "expo-router"



export default function Historico() {


    return (
        <SafeAreaView className="flex-1 bg-white items-center pl-[10px] pr-[10px]" >
            <View className="border-2 border-red-900 h-[1000px] w-full">

                <View>
                    <Text className="text-center">
                        Verifique seu histórico de registro
                    </Text>
                </View>


                <View className="border-2 border-red-500 h-[200px]">
                    <View>
                        <Text>
                            Registro do dia
                        </Text>
                    </View>


                    <View>
                        
                    </View>
                </View>
            </View>

        </SafeAreaView>
    )
}

const styles = StyleSheet.create({

})