import { View, Text, StyleSheet, Image, TextInput, TouchableOpacity } from 'react-native';

export default function Senha(){
  return(
    <View style={styles.container}>
      <Image style={styles.imgMain}
        source={require("./assets/mulher_caderno.png")}
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
    backgroundColor: "#F5AFAF",
    justifyContent: 'center',
    alignItems: 'center'
  },
  imgMain:{
    width: 200,
    height: 250
  },
  span:{
    width: "100%",
    height: "59.75%",
    backgroundColor: "#FFFFFF",
    justifyContent: 'center',
    alignItems: 'center',
    borderTopRightRadius: 50,
    borderTopLeftRadius: 50,
    marginTop: 25
  },
  title:{
    width: "72.5%",
    height: 55 ,
    textAlign: 'left',
    color: "#7D0A0A",
    fontSize: 30,
    fontWeight: 'bold',
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
    fontSize: 18.75,
    paddingLeft: 10,
    marginBottom: 6.25
  },
  password:{
    width: "72.5%",
    color: "#000000",
    fontSize: 18.75,
    textAlign: 'left',
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
    backgroundColor: "#CA6060",
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
