import { View, Text, StyleSheet, Image, TouchableOpacity } from 'react-native';
import { useFonts, YanoneKaffeesatz_400Regular, YanoneKaffeesatz_700Bold } from '@expo-google-fonts/yanone-kaffeesatz';
import { OpenSans_400Regular } from '@expo-google-fonts/open-sans';
import { Link } from 'expo-router';

export default function Index(){
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
      <Text style={styles.upTitle}>Bem vindo ao</Text>
      <Text style={styles.title}>ONNA</Text>
      <Text style={styles.downTitle}>Aplicativo do Profissional</Text>
      <Image style={styles.imgMain}
        source={require("../assets//img/doctors-gif.gif")}
      />
      <TouchableOpacity style={styles.btnMain}>
        <Link href={"/login"}>
            <Text style={styles.signIn}>Login</Text>
        </Link>
      </TouchableOpacity>
      <Text style={styles.signUp}>Não possui cadastro? <Link href={"/signUp"}><Text style={styles.spanSignUp}>Cadastre-se</Text></Link></Text>
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
  upTitle:{
    color: "#000000",
    fontSize: 18.75,
    fontFamily: "OpenSans_400Regular",
    marginTop: 25   
  },
  title:{
    color: "#134611",
    fontSize: 62.5,
    fontFamily: "YanoneKaffeesatz_700Bold"
  },
  downTitle:{
    color: "#000000",
    fontSize: 18.75,
    fontFamily: "OpenSans_400Regular"
  },
  imgMain:{
    width: 350,
    height: 353,
    marginTop: 50,
    marginBottom: 50
  },
  btnMain:{
    width: "75%",
    height: 50,
    backgroundColor: "#3DA35D",
    borderRadius: 18.75,
    justifyContent: 'center',
    alignItems: 'center',
    marginTop: 37.5,
    marginBottom: 25
  },
  signIn:{
    color: "#ffffff",
    fontSize: 25,
    fontFamily: "YanoneKaffeesatz_400Regular"
  },
  signUp:{
    color: "#000000",
    fontSize: 18.75,
    fontFamily: "OpenSans_400Regular"
  },
  spanSignUp:{
    color: "#3E8914",
    fontSize: 18.75,
    fontFamily: "OpenSans_400Regular"
  }
})