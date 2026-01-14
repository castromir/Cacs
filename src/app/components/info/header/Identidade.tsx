"use client" 

import { EditableText } from "../../editable/EditableText"
import { useFichaStore } from "@/src/app/store/fichaStore"

export function Identidade() {
  const nome = useFichaStore((store) => store.identidade.nome)
  const classe  = useFichaStore((store) => store.identidade.classe)
  const setIdentidade = useFichaStore((state) => state.setIdentidade)
  
    return (
      <section className="text-sm flex flex-col w-[130px] gap-2">
        <EditableText
          value={nome}
          onSave={(v) => setIdentidade('nome', v)}
          className="w-24 text-left"
        />

        <EditableText
          value={classe}
          onSave={(v) => setIdentidade('classe', v)}
          className="w-34 text-left"
        />
      </section>
    )
  }