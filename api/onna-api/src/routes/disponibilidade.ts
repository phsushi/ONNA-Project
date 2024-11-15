import { Router } from "express"

import { criar_Disponibilidade, exibir_Disponibilidade, alterar_Disponibilidade, excluir_Disponibilidade } from "../controllers/disponibilidade"

const disponibilidadeRoutes:Router = Router()  

disponibilidadeRoutes.post("/disponibilidade", criar_Disponibilidade)

disponibilidadeRoutes.get("/disponibilidade/:idProfissional", exibir_Disponibilidade)

disponibilidadeRoutes.put("/disponibilidade", alterar_Disponibilidade)

disponibilidadeRoutes.delete("/disponibilidade", excluir_Disponibilidade)

export default disponibilidadeRoutes
