import { View, Text, StyleSheet, Image, TextInput, TouchableOpacity } from 'react-native';
import { useFonts, YanoneKaffeesatz_400Regular, YanoneKaffeesatz_700Bold } from '@expo-google-fonts/yanone-kaffeesatz';
import { OpenSans_400Regular } from '@expo-google-fonts/open-sans';
import { Link } from 'expo-router';

export default function RecoveryPassword(){
  const [fontsLoaded] = useFonts({
    YanoneKaffeesatz_400Regular,
    YanoneKaffeesatz_700Bold,
    OpenSans_400Regular
  })

  if (!fontsLoaded) {
    return null
  }

  return(
    <View style={styles.container}>
      <Image style={styles.imgMain}
        source={require("../assets//img/teammates-gif.gif")}
      />
        <Text style={styles.email}>Atenção</Text>
        <Text style={styles.password}>Enviamos um código para seu email, verifique sua caixa de entrada</Text>
        <Text style={styles.timer}>01:00</Text>
        <TouchableOpacity style={styles.btnMain}>
            <Text style={styles.signIn}>Reenviar</Text>
        </TouchableOpacity>
      <Link href={"/login"}>
        <Text style={styles.signUp}>Já recebeu? <Text style={styles.spanSignUp}>Login</Text></Text>
      </Link>
    </View>
  )
}

const styles = StyleSheet.create({
  container:{
    flex: 1,
    backgroundColor: "#E8FCCF",
    justifyContent: 'center',
    alignItems: 'center'
  },
  imgMain:{
    width: 300,
    height: 303
  },
  email:{
    color: "#134611",
    fontSize: 62.5,
    fontFamily: "YanoneKaffeesatz_700Bold"
  },
  password:{
    width: "75%",
    color: "#000000",
    fontSize: 18.75,
    textAlign: 'center',
    fontFamily: "OpenSans_400Regular"
  },
  timer:{
    width: "75%",
    color: "#000000",
    fontSize: 25,
    textAlign: 'center',
    fontFamily: "YanoneKaffeesatz_700Bold"
  },
  btnMain:{
    width: "75%",
    height: 50,
    backgroundColor: "#3DA35D",
    borderRadius: 18.75,
    justifyContent: 'center',
    alignItems: 'center',
    marginTop: 25,
    marginBottom: 25
  },
  signIn:{
    color: "#FFFFFF",
    fontSize: 25,
    fontFamily: "YanoneKaffeesatz_400Regular"
  },
  signUp:{
    color: "#000000",
    fontSize: 15.625,
    fontFamily: "OpenSans_400Regular",
  },
  spanSignUp:{
    color: "#3E8914",
    fontSize: 15.625,
    fontFamily: "OpenSans_400Regular"
  }
})