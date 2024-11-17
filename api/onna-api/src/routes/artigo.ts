import { Router } from "express"

import { exibir_Artigo_Genero, artigo_Selecionado, consulta_Titulo_Artigo, exibir_Artigos } from "../controllers/artigo"

const artigoRoutes:Router = Router()

artigoRoutes.get("/artigo/genero/:idGenero", exibir_Artigo_Genero)
artigoRoutes.get("/artigo/selecionado/:idArtigo", artigo_Selecionado)
artigoRoutes.get("/artigo/:titulo", consulta_Titulo_Artigo)
artigoRoutes.get("/artigo", exibir_Artigos)

export default artigoRoutes
