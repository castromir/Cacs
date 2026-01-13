'use client'

import { useState } from 'react'

type EditableFieldProps<T> = {
  value: T
  onSave: (value: T) => void
  type?: 'text' | 'number'
  className?: string
}

export function EditableField<T extends string | number>({
  value,
  onSave,
  type = 'text',
  className,
}: EditableFieldProps<T>) {
  const [editing, setEditing] = useState(false)
  const [draft, setDraft] = useState<T>(value)

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
        onChange={(e) =>
          setDraft(
            (type === 'number'
              ? Number(e.target.value)
              : e.target.value) as T
          )
        }
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
      className={`cursor-pointer ${className}`}
    >
      {value}
    </span>
  )
}
