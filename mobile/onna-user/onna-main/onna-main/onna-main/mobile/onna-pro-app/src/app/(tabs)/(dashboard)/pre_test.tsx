import { Link } from "expo-router"
import { SafeAreaView, View, StatusBar, Text, Image, Pressable } from "react-native"

export default function Community() {
    return (
        <SafeAreaView className="flex-1 bg-red-300" >
            <View className="w-full h-full justify-center items-center gap-[50px]" >
                <StatusBar barStyle={"dark-content"} />

                <View className="pl-[7.5px] pr-[7.5px] mt-10 w-[380px] h-[10.75%] bg-white items-center flex-column justify-center  rounded-[15px] gap-4 shadow-black shadow-2xl" >
                    <Text className="text-[18.5px] text-center color-red-900 font-Ibold" >Bem vindo(a),
                        <Text className="text-[18.5px] text-center color-black font-Ibold" > ao teste rápido de gravidez</Text>
                    </Text>
                </View>

                <View className="bg-white rounded-[15px] gap-4 shadow-black shadow-2xl whitespace-nowrap  w-[380px] h-[20.75%] items-center" >
                    <Text className="text-[16.5px] text-center color-balck font-Ibold mt-[20px] ">Antes de receber o resultado,
                        <Text className="text-[16.5px] text-center color-red-900 font-Ibold m-5" >
                            é de suma importância saber que esse teste não substitui o teste de gravidez convencional,
                            como o de sangue. 
                        </Text>
                         Nosso teste só lhe entrega uma ideia de uma possível gravidez ou não.
                    </Text>
                </View>

                <Pressable className="w-[75%] h-[50px] bg-red-500 justify-center items-center rounded-[12.5px] shadow-xl shadow-black"  >

                    <Link href={"../q1"}>
                        <Text className="text-[18.75px] color-white font-Imedium" >Iniciar teste</Text>
                    </Link>

                </Pressable>


            </View>
        </SafeAreaView >
    )
}