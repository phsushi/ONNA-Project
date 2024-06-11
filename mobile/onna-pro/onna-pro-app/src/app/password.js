import { View, Text, StyleSheet, Image, TextInput, TouchableOpacity } from 'react-native';
import { useFonts, YanoneKaffeesatz_400Regular } from '@expo-google-fonts/yanone-kaffeesatz';
import { OpenSans_400Regular } from '@expo-google-fonts/open-sans';
import { Link } from 'expo-router';

export default function Password(){
  const [fontsLoaded] = useFonts({
    YanoneKaffeesatz_400Regular,
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
        <Text style={styles.title}>Definir Senha</Text>
        <Text style={styles.email}>Senha</Text>
        <TextInput style={styles.txtEmail}
            placeholder='************'
            keyboardType='text'
        />
        <Text style={styles.password}>Confirmar Senha</Text>
        <TextInput style={styles.txtPassword}
            placeholder='************'
            keyboardType='text'
        />
        <TouchableOpacity style={styles.btnMain}>
            <Text style={styles.signIn}>Salvar</Text>
      </TouchableOpacity>
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
    height: "68.75%",
    backgroundColor: "#FFFFFF",
    justifyContent: 'center',
    alignItems: 'center',
    borderTopRightRadius: 50,
    borderTopLeftRadius: 50,
    marginTop: 25
  },
  title:{
    width: "72.5%",
    textAlign: 'left',
    color: "#134611",
    fontSize: 50,
    fontFamily: "YanoneKaffeesatz_700Bold",
    marginBottom: 25
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
  }
})