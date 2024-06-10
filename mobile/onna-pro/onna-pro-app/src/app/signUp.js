import { View, Text, StyleSheet, Image, TextInput, TouchableOpacity } from 'react-native';
import { useFonts, YanoneKaffeesatz_400Regular, YanoneKaffeesatz_700Bold } from '@expo-google-fonts/yanone-kaffeesatz';
import { OpenSans_400Regular } from '@expo-google-fonts/open-sans';
import { Link } from 'expo-router'

export default function SignUp(){
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
        source={require("../assets//img/researcher-gif.gif")}
      />
      <View style={styles.span}>
      <Text style={styles.email}>Nome Completo</Text>
        <TextInput style={styles.txtEmail}
            placeholder='Bombs Ricardinho'
            keyboardType='text'
        />
        <Text style={styles.email}>Email</Text>
        <TextInput style={styles.txtEmail}
            placeholder='ricardinho@gmail.com'
            keyboardType='text'
        />
        <Text style={styles.password}>Senha</Text>
        <TextInput style={styles.txtPassword}
            placeholder='************'
            keyboardType='text'
        />
        <TouchableOpacity style={styles.btnMain}>
            <Text style={styles.signIn}>Continuar</Text>
      </TouchableOpacity>
      <Text style={styles.or}>Ou</Text>
      <View style={styles.images}>
        <Image style={styles.imgFacebook}
            source={require("../assets/img/facebook.png")}
        />
        <Image style={styles.imgGoogle}
            source={require("../assets//img/google.png")}
        />
        <Image style={styles.imgApple}
            source={require("../assets//img/apple.png")}
        />
      </View>
      <Link href={"/login"}>
        <Text style={styles.signUp}>Já possui cadastro? <Text style={styles.spanSignUp}>Login</Text></Text>
      </Link>
      </View>
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
    width: 250,
    height: 253
  },
  span:{
    width: "100%",
    height: "72.5%",
    backgroundColor: "#FFFFFF",
    justifyContent: 'center',
    alignItems: 'center',
    borderTopRightRadius: 37.5,
    borderTopLeftRadius: 37.5
  },
  email:{
    width: "72.5%",
    color: "#000000",
    fontSize: 18.75,
    textAlign: 'left',
    fontFamily: "OpenSans_400Regular"
  },
  txtEmail:{
    width: "75%",
    height: 43.75,
    color: "#000000",
    backgroundColor: "#EDEDED",
    borderRadius: 12.5,
    textAlign: 'justify',
    fontFamily: "YanoneKaffeesatz_400Regular",
    fontSize: 18.75,
    paddingLeft: 10,
    marginBottom: 6.25
  },
  password:{
    width: "72.5%",
    color: "#000000",
    fontSize: 18.75,
    textAlign: 'left',
    fontFamily: "OpenSans_400Regular"
  },
  txtPassword:{
    width: "75%",
    height: 43.75,
    color: "#000000",
    backgroundColor: "#EDEDED",
    borderRadius: 12.5,
    textAlign: 'justify',
    fontFamily: "YanoneKaffeesatz_400Regular",
    fontSize: 18.75,
    paddingLeft: 10,
    marginBottom: 6.25
  },
  recoverPassword:{
    width: "72.5%",
    color: "#000000",
    fontSize: 15.625,
    textAlign: 'left',
    fontFamily: "OpenSans_400Regular"
  },
  spanRecoverPassword:{
    color: "#3E8914",
    fontSize: 15.625,
    fontFamily: "OpenSans_400Regular"
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
    color: "#000000",
    fontSize: 25,
    fontFamily: "YanoneKaffeesatz_400Regular"
  },
  or:{
    width: "75%",
    color: "#000000",
    fontSize: 18.75,
    textAlign: 'center'
  },
  images:{
    width: "75%",
    height: "18.75%",
    justifyContent: 'center',
    alignItems: 'center',
    flexDirection: 'row',
    gap: 18.75
  },
  imgFacebook:{
    width: 50,
    height: 50
  },
  imgGoogle:{
    width: 50,
    height: 50
  },
  imgApple:{
    width: 50,
    height: 50
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