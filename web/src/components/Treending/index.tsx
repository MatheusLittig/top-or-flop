import React, { useEffect, useState } from 'react'

import { Box, Heading } from '@chakra-ui/react'
import { getAnimeTreending } from '../../services/JikanAPI'

interface AnimeTreending {
  title: string
  synopsis: string
}

const Treending: React.FC = () => {
  const [treendingList, setTreendinList] = useState<AnimeTreending[]>([
    {
      title: '',
      synopsis: ''
    }
  ])

  useEffect(() => {
    getAnimeTreending(2021, 'winter').then(res =>
      res.map(anime =>
        setTreendinList([{ title: anime.title, synopsis: anime.synopsis }])
      )
    )

    console.log(treendingList)
  }, [])

  return (
    <Box gridArea="trending" bg="gray.700" p={3}>
      <Heading as="h3" fontSize="MD">
        {treendingList.map(anime => anime.title)}
      </Heading>
    </Box>
  )
}

export default Treending
