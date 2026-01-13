'use client'

import { useState } from 'react'

export type AtributosData = {
  forca: number
  agilidade: number
  intelecto: number
  vigor: number
  presenca: number
  instinto: number
}

type Props = {
  initialData: AtributosData
}

export function Atributos({ initialData }: Props) {
  const [atributos, setAtributos] = useState<AtributosData>(initialData)

  function update<K extends keyof AtributosData>(
    key: K,
    value: number
  ) {
    setAtributos((prev) => ({
      ...prev,
      [key]: value,
    }))
  }

  return (
    <section>
      <ul className='flex gap-4'>
        <Atributo
          label="FOR"
          value={atributos.forca}
          onChange={(v) => update('forca', v)}
        />
        <Atributo
          label="AGI"
          value={atributos.agilidade}
          onChange={(v) => update('agilidade', v)}
        />
        <Atributo
          label="INS"
          value={atributos.instinto}
          onChange={(v) => update('instinto', v)}
        />
        <Atributo
          label="INT"
          value={atributos.intelecto}
          onChange={(v) => update('intelecto', v)}
        />
        <Atributo
          label="VIG"
          value={atributos.vigor}
          onChange={(v) => update('vigor', v)}
        />
        <Atributo
          label="PRE"
          value={atributos.presenca}
          onChange={(v) => update('presenca', v)}
        />
      </ul>
    </section>
  )
}

type AtributoProps = {
  label: string
  value: number
  onChange: (value: number) => void
}

function Atributo({ label, value, onChange }: AtributoProps) {
  return (
    <li className="flex flex-col items-center">
      <span className="w-10">{label}</span>

      <input
        type="number"
        value={value}
        onChange={(e) => onChange(Number(e.target.value))}
        className="w-6 text-center"
      />
    </li>
  )
}
//711.6  327.2
//353.2 881.2
// 500 880.4