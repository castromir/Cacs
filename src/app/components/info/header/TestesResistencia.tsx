'use client'

import { useState } from 'react'

export type TestesResistenciaData = {
  fortitude: number
  reflexos: number
  vontade: number
}

type Props = {
  initialData: TestesResistenciaData
}

export function TestesResistencia({ initialData }: Props) {
  const [testesResistencia, setTestesResistencia] = useState<TestesResistenciaData>(initialData)

  function update<K extends keyof TestesResistenciaData>(
    key: K,
    value: number
  ) {
    setTestesResistencia((prev) => ({
      ...prev,
      [key]: value,
    }))
  }

  return (
    <section>
      <ul className='flex gap-4'>
        <Atributo
          label="FRT"
          value={testesResistencia.fortitude}
          onChange={(v) => update('fortitude', v)}
        />
        <Atributo
          label="REF"
          value={testesResistencia.reflexos}
          onChange={(v) => update('reflexos', v)}
        />
        <Atributo
          label="VON"
          value={testesResistencia.vontade}
          onChange={(v) => update('vontade', v)}
        />
      </ul>
    </section>
  )
}

type TestesResistenciaProps = {
  label: string
  value: number
  onChange: (value: number) => void
}

function Atributo({ label, value, onChange }: TestesResistenciaProps) {
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