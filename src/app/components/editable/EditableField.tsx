'use client'

import { useState } from 'react'

type EditableFieldProps = {
  value: string | number
  onSave: (value: string | number) => void
  type?: 'text' | 'number'
  className?: string
}

export function EditableField({
  value,
  onSave,
  type = 'text',
  className,
}: EditableFieldProps) {
  const [editing, setEditing] = useState(false)
  const [draft, setDraft] = useState<string | number>(value)

  function startEdit() {
    setDraft(value)
    setEditing(true)
  }

  function cancel() {
    setEditing(false)
    setDraft(value)
  }

  function confirm() {
    onSave(draft)
    setEditing(false)
  }

  if (editing) {
    return (
      <input
        autoFocus
        type={type}
        value={draft}
        onChange={(e) => {
          const nextValue =
            type === 'number'
              ? Number(e.target.value)
              : e.target.value

          setDraft(nextValue)
        }}
        onBlur={confirm}
        onKeyDown={(e) => {
          if (e.key === 'Enter') confirm()
          if (e.key === 'Escape') cancel()
        }}
        className={`
          bg-transparent
          border-none
          outline-none
          focus:outline-none
          focus:ring-0
          ${className ?? ''}
        `}
      />
    )
  }

  return (
    <span
      onClick={startEdit}
      className={`cursor-pointer ${className ?? ''}`}
    >
      {value}
    </span>
  )
}
